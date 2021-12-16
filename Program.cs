using System;

namespace Final2
{
    class Node{
        public int level;
        public string Name;
        public Node Left;
        public Node Right;
        public static Node[] FireBolt = new Node[99];
        public static Node[] NapalmBeat = new Node[99];
        public Node (string Name){
            this.Name = Name;
            level = 0;
            Left = null;
            Right = null;
        }
    }
    class Program
    {

        static void Skills(){
            Node.FireBolt[0] = new Node("Fire Bolt");
            Node.FireBolt[1] = new Node("Fire Ball");
            Node.FireBolt[2] = new Node("Fire Wall");

            Node.FireBolt[0].Left = Node.FireBolt[1];
            Node.FireBolt[1].Left = Node.FireBolt[2];

            Node.NapalmBeat[0] = new Node("Napalm Beat");
            Node.NapalmBeat[1] = new Node("Safety Wall");
            Node.NapalmBeat[2] = new Node("Soul Strike");

            Node.NapalmBeat[0].Left = Node.NapalmBeat[1];
            Node.NapalmBeat[0].Right = Node.NapalmBeat[2];
        }

        static void Main(string[] args)
        {
            Skills();
            bool c= true;
            while(c){
                Console.Write("Input skill name: ");
                String skill = Console.ReadLine();
                if(skill == Node.FireBolt[0].Name){
                    for(int i=0;i<=2;i++){
                        Console.WriteLine("Add dependency for " + Node.FireBolt[i].Name +"? (Y/N):");
                        char ans = char.Parse(Console.ReadLine());
                        if(ans == 'Y' || ans == 'y'){
                            Node.FireBolt[i].level += 1;

                        }
                        else if(ans == 'N' || ans == 'n'){
                            for(int u=i-1;u>=0;u--){
                                Console.WriteLine("Add dependency for " + Node.FireBolt[u].Name +"? (Y/N):");
                                ans = char.Parse(Console.ReadLine());
                                if(ans == 'Y' || ans == 'y'){
                                    Node.FireBolt[u].level += 1;
                                }
                            }
                        }
                    }
                    
                    
                }
                else if(skill == Node.NapalmBeat[0].Name){
                    for(int i=0;i<=2;i++){
                        Console.WriteLine("Add dependency for " + Node.NapalmBeat[i].Name +"? (Y/N):");
                        char ans = char.Parse(Console.ReadLine());
                        if(ans == 'Y' || ans == 'y'){
                            Node.NapalmBeat[i].level += 1;
                        }
                    }
                }
                else if(skill == "?"){
                        for(int j=0;j<=2;j++){
                            if(Node.FireBolt[j].level <1){
                                Console.WriteLine(Node.FireBolt[j].Name);
                            }
                        }
                        for(int k=0;k<=2;k++){
                            if(Node.NapalmBeat[k].level <1){
                                Console.WriteLine(Node.NapalmBeat[k].Name);
                            }
                        }
                        
                    }
            }
            
        }
    }
}
