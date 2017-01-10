namespace MobilePhoneDevice
{
    using System;

    class GSMTests
    {
        static void Main(string[] args)
        {
            var gsm = new GSM("Sony Xperia", "Sony", 500.5M, "Mr. X", new Battery(), new Display(6.5, 65000));
            var gsms = new GSM[]
            {
                new GSM("ABV", "A", 500.5M, "Alf", new Battery("BatModel", 10, 4, BatteryType.LiIon), new Display(6.5, 65000)),
                new GSM("ASD", "B", 500.5M, "Smurf", new Battery(), new Display(7, 65000)),
                new GSM("Efd", "C", 500.5M, "Smith", new Battery("Some model", BatteryType.NiCd), new Display(5, 65000)),
                new GSM("WSD", "D", 500.5M, "Batman", new Battery("tralala", 24, 9.8, BatteryType.NiCd), new Display(5.5, 65000)),
                new GSM("dsa", "E", 500.5M, "Superman", new Battery(), new Display(6, 65000))
            };

            Console.WriteLine(gsm);

            foreach (var phone in gsms)
            {
                Console.WriteLine(phone);
            }

            Console.WriteLine(GSM.IPhone4S);

            for (int i = 0; i < 10; i++)
            {
                gsm.AddCall(new Call()
                {
                    // just some numbers
                    DialedPhone = "000" + i,
                    Duration = (long)(i + 1) * 100
                });
            }

            var maxCall = new Call();
            foreach (Call call in gsm.CallHistory)
            {
                Console.WriteLine(call);
                if (maxCall.Duration < call.Duration)
                    maxCall = call;
            }

            Console.WriteLine("Total price: " + gsm.CalculateTotalPrice(0.37m));

            gsm.DeleteCall(maxCall);
            Console.WriteLine("Total price: " + gsm.CalculateTotalPrice(0.37m));

            Console.WriteLine("Call history count: " + gsm.CallHistory.Count);
            gsm.ClearHistory();
            Console.WriteLine("Call history count: " + gsm.CallHistory.Count);
        }
    }
}