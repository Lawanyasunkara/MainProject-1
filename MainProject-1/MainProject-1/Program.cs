using Simplilearn_1;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MainProject_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        mar:
            Console.WriteLine("1.Add by Playername 2.Remove by PlayerID 3.Get Player by ID 4.Get Player by Name 5.Get All Players");
            int l = Convert.ToInt32(Console.ReadLine());
            switch (l)
            {
                case 1:
                there:
                    OnedayTeam n = new OnedayTeam();
                    if (OnedayTeam.Oneday.Count != OnedayTeam.Oneday.Capacity)
                    {
                        Console.Write("Enter Player Id:");
                        n.PlayerId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Player Name:");
                        n.PlayerName = Console.ReadLine();
                        Console.Write("Enter Player Age:");
                        n.PlayerAge = Convert.ToInt32(Console.ReadLine());

                        n.Add(n);
                    }
                    else
                    {
                        Console.WriteLine("Capacity is full");
                        goto mar;
                    }



                    Console.WriteLine("Do you want to continue?.Press yes");
                    string g = Console.ReadLine();
                    if (g == "yes")
                    {
                        goto there;
                    }
                    break;
                case 2:
                    OnedayTeam s = new OnedayTeam();
                    Console.Write("Enter Player Id to remove:");
                    int j = Convert.ToInt32(Console.ReadLine());
                    s.Remove(j);
                    break;
                case 3:
                    OnedayTeam ps = new OnedayTeam();
                    Console.Write("Enter Player Id to search:");
                    int ki = Convert.ToInt32(Console.ReadLine());
                    Player P = ps.GetPlayerById(ki);
                    Console.WriteLine($"{P.PlayerId} {P.PlayerName} {P.PlayerAge}");
                    break;
                case 4:
                    OnedayTeam ri = new OnedayTeam();
                    Console.Write("Enter Player Name to search:");
                    string ik = Console.ReadLine();
                    Player oi = ri.GetPlayerByName(ik);
                    Console.WriteLine($"{oi.PlayerId} {oi.PlayerName} {oi.PlayerAge}");
                    break;
                case 5:
                    Console.WriteLine("List all players");
                    List<Player> ms = new List<Player>();
                    OnedayTeam loi = new OnedayTeam();
                    ms = loi.GetAllPlayers();
                    foreach (var item in ms)
                    {
                        Console.WriteLine($"{item.PlayerId} {item.PlayerName} {item.PlayerAge}");
                    }
                    break;


            }
            Console.WriteLine("Do you want to go to start? Enter yes");
            string vi = Console.ReadLine();
            if (vi == "yes")
            {
                goto mar;
            }
            Console.ReadLine();
        }
    }
}