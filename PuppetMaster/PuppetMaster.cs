﻿using Grpc.Core;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace PuppetMaster {
    struct ServerStruct {
        public string url;
       
        public PuppetMasterService.PuppetMasterServiceClient channel;

        public ServerStruct(string u, PuppetMasterService.PuppetMasterServiceClient c) {
            url = u;
            channel = c;
        }
    }

    class PuppetMaster {
        public const String hostname = "localhost";
        public const String port = "10001";
        
        private Server server;

        Dictionary<String, String> servers_url = new Dictionary<String, String>();

        Dictionary<String, ServerStruct> _servers = new Dictionary<String, ServerStruct>();


        Queue<String> commandQueue= new Queue<String>();
        List<GrpcChannel> channels = new List<GrpcChannel>();
        Dictionary<String, PuppetMasterService.PuppetMasterServiceClient> servers = new Dictionary<String, PuppetMasterService.PuppetMasterServiceClient>();
        Dictionary<String, PuppetMasterService.PuppetMasterServiceClient> clients = new Dictionary<String, PuppetMasterService.PuppetMasterServiceClient>();
        PuppetMasterService.PuppetMasterServiceClient s;
  
        public PuppetMaster() {
            // setup the puppet master service
            
            server = new Server {
                Services = { PuppetMasterService.BindService(new PuppetService()) },
                Ports = { new ServerPort(hostname, Int32.Parse(port), ServerCredentials.Insecure) }
            };
            server.Start();

            AppContext.SetSwitch(
                "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);

            
        }

        public void addComand(String command) {
            commandQueue.Enqueue(command);
            System.Diagnostics.Debug.WriteLine("added command:", command);
        }

        public void runCommands() {
            foreach(var command in commandQueue) {
                executeCommand(command);
                System.Diagnostics.Debug.WriteLine("executing command:",command);
            }
            commandQueue.Clear();
        }

        public void runNextCommand(){
            executeCommand(commandQueue.Dequeue());
        }

        private void addServerToDict(String server_id, String url){
            GrpcChannel channel = GrpcChannel.ForAddress("http://" + url);
            PuppetMasterService.PuppetMasterServiceClient client = new PuppetMasterService.PuppetMasterServiceClient(channel);
            channels.Add(channel);
            servers.Add(server_id, client);
        }
        private void addClientToDict(String username, String url)
        {
            GrpcChannel channel = GrpcChannel.ForAddress("http://" + url);
            PuppetMasterService.PuppetMasterServiceClient client = new PuppetMasterService.PuppetMasterServiceClient(channel);
            channels.Add(channel);
            clients.Add(username, client);
        }

        public void Status()
        {

            foreach (var server in servers)
            {
                _ = server.Value.StatusAsync(new StatusRequest { });
            }
            foreach (var client in clients)
            {
                _ = client.Value.StatusAsync(new StatusRequest { });
            }

        }

        public void executeCommand(String c) {
            string[] args = c.Split(" ");
            String server_id;
            switch (args[0]) {
                case "ReplicationFactor":
                    break;
                case "Server":
                    server_id = args[1];
                    String url = args[2];   //ex: localhost:1001
                    String min_delay = args[3];
                    String max_delay = args[4];
                    System.Diagnostics.Debug.WriteLine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                   
                    Process process = new Process();
                    if(!servers.ContainsKey(server_id))
                        addServerToDict(server_id, url);
                    servers_url.Add(server_id, url);
                    //Path to server .exe , maybe it should be the "release" version instead of "debug"
                    process.StartInfo.FileName = "..\\..\\..\\..\\GStoreServer\\bin\\Debug\\netcoreapp3.1\\GStoreServer.exe";
                    process.StartInfo.Arguments = server_id + " " + url + " " + min_delay + " " + max_delay;
                    process.Start();
                    break;
                case "Partition":
                    int r = int.Parse(args[1]);
                    String part_name = args[2];
                    for (int i = 0; i < r; i++) {
                        server_id = args[i + 3];
                        AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
                        GrpcChannel channel = GrpcChannel.ForAddress("http://" + servers_url[server_id]);
                        PuppetMasterService.PuppetMasterServiceClient client = new PuppetMasterService.PuppetMasterServiceClient(channel);
                        PartitionReply reply = client.Partition(new PartitionRequest { 
                            PartitionName = part_name
                        });
                        if (reply.Ok == true) {
                            System.Diagnostics.Debug.WriteLine("Received answer from partition: " + reply.Ok);
                        } else {
                            System.Diagnostics.Debug.WriteLine("Received answer from partition f: " + reply.Ok);
                        }
                    }
                    break;
                case "Client":
                    break;
                case "Status":
                    Status();
                    break;
                case "Crash":
                    break;
                case "Freeze":
                    break;
                case "Unfreeze":
                    break;
                case "Wait":
                    string ms = args[1];
                    System.Threading.Thread.Sleep(int.Parse(ms));
                    break;
                default:
                    break;
            }

        }
    }

    public class PuppetService : PuppetMasterService.PuppetMasterServiceBase {
        public PuppetService() {

        }

        //TODO
        public override Task<ReplicationFactorReply> ReplicationFactor(ReplicationFactorRequest request, ServerCallContext context) {
            return Task.FromResult(new ReplicationFactorReply { }) ;
        }
       
    }
}
