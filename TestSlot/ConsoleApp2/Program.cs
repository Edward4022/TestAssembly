using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Game
    {
        public Ball _1 { get; set; }
        public Ball _2 { get; set; }
        public Ball _3 { get; set; }
        public Ball _4 { get; set; }
        public Ball _5 { get; set; }

        public decimal win { get; set; }
    }

    public class SLOT
    {
        public List<Ball> set { get; set; }
    }

    public class table_5
    {
        public SLOT first { get; set; }
        public SLOT second { get; set; }
        public SLOT third { get; set; }
        public SLOT forth { get; set; }
        public SLOT fifth { get; set; }
    }

    public class Ball
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Payout
    {
        public int BallId { get; set; }
        public int Count { get; set; }
        //public int PayoutM { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var balls = new List<Ball>() {
                new Ball(){ID = 0, Name = "9"},
                new Ball(){ID = 1, Name = "10"},
                new Ball(){ID = 2, Name = "J"},
                new Ball(){ID = 3, Name = "Q"},
                new Ball(){ID = 4, Name = "K"},
                new Ball(){ID = 5, Name = "S"},
                new Ball(){ID = 6, Name = "W"},
            };

            var PayOutList = new Dictionary<Payout, decimal>()
            {
                {new Payout(){ BallId = 4, Count = 3},  5 },
                {new Payout(){ BallId = 4, Count = 4},  30 },
                {new Payout(){ BallId = 4, Count = 5},  100 },
                {new Payout(){ BallId = 3, Count = 3},  5 },
                {new Payout(){ BallId = 3, Count = 4},  25 },
                {new Payout(){ BallId = 3, Count = 5},  100 },
                {new Payout(){ BallId = 2, Count = 3},  5 },
                {new Payout(){ BallId = 2, Count = 4},  20 },
                {new Payout(){ BallId = 2, Count = 5},  75 },
                {new Payout(){ BallId = 1, Count = 3},  5 },
                {new Payout(){ BallId = 1, Count = 4},  20 },
                {new Payout(){ BallId = 1, Count = 5},  75 },
                {new Payout(){ BallId = 0, Count = 3},  5 },
                {new Payout(){ BallId = 0, Count = 4},  10 },
                {new Payout(){ BallId = 0, Count = 5},  50 },
                {new Payout(){ BallId = 5, Count = 3},  50 },
            };

            #region slot1
            var slot1 = new List<Ball>();
            slot1.Add(balls.Find(x => x.Name == "K"));
            slot1.Add(balls.Find(x => x.Name == "Q"));
            slot1.Add(balls.Find(x => x.Name == "J"));
            slot1.Add(balls.Find(x => x.Name == "10"));
            slot1.Add(balls.Find(x => x.Name == "9"));
            slot1.Add(balls.Find(x => x.Name == "9"));
            slot1.Add(balls.Find(x => x.Name == "K"));
            slot1.Add(balls.Find(x => x.Name == "Q"));
            slot1.Add(balls.Find(x => x.Name == "J"));
            slot1.Add(balls.Find(x => x.Name == "10"));
            slot1.Add(balls.Find(x => x.Name == "9"));
            slot1.Add(balls.Find(x => x.Name == "10"));
            slot1.Add(balls.Find(x => x.Name == "Q"));
            slot1.Add(balls.Find(x => x.Name == "J"));
            slot1.Add(balls.Find(x => x.Name == "10"));
            slot1.Add(balls.Find(x => x.Name == "9"));
            slot1.Add(balls.Find(x => x.Name == "9"));
            slot1.Add(balls.Find(x => x.Name == "J"));
            slot1.Add(balls.Find(x => x.Name == "10"));
            slot1.Add(balls.Find(x => x.Name == "9"));
            #endregion
            #region slot2
            var slot2 = new List<Ball>();
            slot2.Add(balls.Find(x => x.Name == "W"));
            slot2.Add(balls.Find(x => x.Name == "K"));
            slot2.Add(balls.Find(x => x.Name == "Q"));
            slot2.Add(balls.Find(x => x.Name == "J"));
            slot2.Add(balls.Find(x => x.Name == "10"));
            slot2.Add(balls.Find(x => x.Name == "9"));
            slot2.Add(balls.Find(x => x.Name == "S"));
            slot2.Add(balls.Find(x => x.Name == "K"));
            slot2.Add(balls.Find(x => x.Name == "Q"));
            slot2.Add(balls.Find(x => x.Name == "J"));
            slot2.Add(balls.Find(x => x.Name == "10"));
            slot2.Add(balls.Find(x => x.Name == "9"));
            slot2.Add(balls.Find(x => x.Name == "K"));
            slot2.Add(balls.Find(x => x.Name == "Q"));
            slot2.Add(balls.Find(x => x.Name == "J"));
            slot2.Add(balls.Find(x => x.Name == "10"));
            slot2.Add(balls.Find(x => x.Name == "9"));
            slot2.Add(balls.Find(x => x.Name == "J"));
            slot2.Add(balls.Find(x => x.Name == "J"));
            slot2.Add(balls.Find(x => x.Name == "9"));
            #endregion
            #region slot3
            var slot3 = new List<Ball>();
            slot3.Add(balls.Find(x => x.Name == "W"));
            slot3.Add(balls.Find(x => x.Name == "K"));
            slot3.Add(balls.Find(x => x.Name == "Q"));
            slot3.Add(balls.Find(x => x.Name == "J"));
            slot3.Add(balls.Find(x => x.Name == "10"));
            slot3.Add(balls.Find(x => x.Name == "9"));
            slot3.Add(balls.Find(x => x.Name == "S"));
            slot3.Add(balls.Find(x => x.Name == "K"));
            slot3.Add(balls.Find(x => x.Name == "Q"));
            slot3.Add(balls.Find(x => x.Name == "J"));
            slot3.Add(balls.Find(x => x.Name == "10"));
            slot3.Add(balls.Find(x => x.Name == "9"));
            slot3.Add(balls.Find(x => x.Name == "K"));
            slot3.Add(balls.Find(x => x.Name == "Q"));
            slot3.Add(balls.Find(x => x.Name == "J"));
            slot3.Add(balls.Find(x => x.Name == "10"));
            slot3.Add(balls.Find(x => x.Name == "9"));
            slot3.Add(balls.Find(x => x.Name == "J"));
            slot3.Add(balls.Find(x => x.Name == "10"));
            slot3.Add(balls.Find(x => x.Name == "9"));
            #endregion
            #region slot4
            var slot4 = new List<Ball>();
            slot4.Add(balls.Find(x => x.Name == "W"));
            slot4.Add(balls.Find(x => x.Name == "K"));
            slot4.Add(balls.Find(x => x.Name == "Q"));
            slot4.Add(balls.Find(x => x.Name == "J"));
            slot4.Add(balls.Find(x => x.Name == "10"));
            slot4.Add(balls.Find(x => x.Name == "9"));
            slot4.Add(balls.Find(x => x.Name == "S"));
            slot4.Add(balls.Find(x => x.Name == "K"));
            slot4.Add(balls.Find(x => x.Name == "Q"));
            slot4.Add(balls.Find(x => x.Name == "J"));
            slot4.Add(balls.Find(x => x.Name == "10"));
            slot4.Add(balls.Find(x => x.Name == "9"));
            slot4.Add(balls.Find(x => x.Name == "K"));
            slot4.Add(balls.Find(x => x.Name == "Q"));
            slot4.Add(balls.Find(x => x.Name == "J"));
            slot4.Add(balls.Find(x => x.Name == "10"));
            slot4.Add(balls.Find(x => x.Name == "9"));
            slot4.Add(balls.Find(x => x.Name == "J"));
            slot4.Add(balls.Find(x => x.Name == "10"));
            slot4.Add(balls.Find(x => x.Name == "9"));
            #endregion
            #region slot5
            var slot5 = new List<Ball>();
            slot5.Add(balls.Find(x => x.Name == "W"));
            slot5.Add(balls.Find(x => x.Name == "K"));
            slot5.Add(balls.Find(x => x.Name == "Q"));
            slot5.Add(balls.Find(x => x.Name == "J"));
            slot5.Add(balls.Find(x => x.Name == "10"));
            slot5.Add(balls.Find(x => x.Name == "9"));
            slot5.Add(balls.Find(x => x.Name == "9"));
            slot5.Add(balls.Find(x => x.Name == "K"));
            slot5.Add(balls.Find(x => x.Name == "Q"));
            slot5.Add(balls.Find(x => x.Name == "J"));
            slot5.Add(balls.Find(x => x.Name == "10"));
            slot5.Add(balls.Find(x => x.Name == "9"));
            slot5.Add(balls.Find(x => x.Name == "K"));
            slot5.Add(balls.Find(x => x.Name == "Q"));
            slot5.Add(balls.Find(x => x.Name == "J"));
            slot5.Add(balls.Find(x => x.Name == "10"));
            slot5.Add(balls.Find(x => x.Name == "9"));
            slot5.Add(balls.Find(x => x.Name == "J"));
            slot5.Add(balls.Find(x => x.Name == "10"));
            slot5.Add(balls.Find(x => x.Name == "9"));
            #endregion
            
            var End = new List<Game>();
            var j = 0;

            var Table = new Dictionary<int, SLOT> {
                { 1 ,new SLOT() { set = slot1 } },
                { 2 ,new SLOT() { set = slot2 } },
                { 3 ,new SLOT() { set = slot3 } },
                { 4 ,new SLOT() { set = slot4 } },
                { 5 ,new SLOT() { set = slot5 } },
            };


            do
            {
                var arr = new Ball[5];
                Random rnd = new Random(Guid.NewGuid().GetHashCode());

                var BallCount = new Dictionary<int, int>()
                {
                    {0,   0},
                    {1,  0},
                    {2,   0},
                    {3,   0},
                    {4,   0},
                    {5,   0},
                    {6,   0},
                };

                for (var i = 1; i <= 5; i ++)
                {
                    var r = rnd.Next(0,19);
                    var ex_count = 0m;
                    var count = 0m;

                    var s = Table.First(x => x.Key == i).Value;
                    BallCount[s.set[r].ID] = BallCount[s.set[r].ID] += 1;
                    arr[i - 1] = s.set[r];
                }

                var winBall = new Ball();
                var countBall = 0;
                for(var i = 0; i < arr.Count(); i++)
                {
                    winBall = arr[0];
                    if (arr[0] != arr[i] && arr[i] != balls.Last())
                        break;
                    countBall++;
                }

                var _win = PayOutList
                    .FirstOrDefault(x => x.Key.BallId == winBall.ID && x.Key.Count == countBall)
                    .Value;
                
                End.Add(new Game()
                    {
                        _1 = arr[0],
                        _2 = arr[1],
                        _3 = arr[2],
                        _4 = arr[3],
                        _5 = arr[4],
                        win = _win
                    }
                );
                
                j++;
            }
            while (j < 10000);

            foreach (var a in End)
                Console.WriteLine($"{a._1.Name}\t{a._2.Name}\t{a._3.Name}\t{a._4.Name}\t{a._5.Name} \t\t {a.win}");
            Console.ReadLine();
        }
    }
}
