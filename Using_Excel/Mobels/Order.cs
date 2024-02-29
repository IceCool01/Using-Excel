using System;

namespace Using_Excel.Mobels
{
    public class Order : Base
    {
        public int Number { get; set; }
        public int Amount { get; set; }
        public DateTime DateOfCreate { get; set; }
        public int ProductId { get; set; }
        public int ClientId { get; set; }
    }
}
