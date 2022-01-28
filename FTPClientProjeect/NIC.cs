using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTPClientProjeect
{
    internal class NIC
    {
        public string manufacture { get; set; }
        public string physicalAddress { get; set; }
        public CardType cardType { get; set; }

        static NIC nic;


        NIC()
        {
            manufacture = String.Empty;
            physicalAddress = String.Empty;
            cardType = CardType.None;
        }

        public override string ToString()
        {
            return $"Manufacture . . . . . . . . . . . : {manufacture},\nPhysical Address. . . . . . . . . : {physicalAddress},\nCardType  . . . . . . . . . . . . : {cardType}";
        }

        public static NIC CreateInstance()
        {
            if (nic == null)
                nic = new NIC();

            return nic;
        }



    }
}
