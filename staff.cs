class Staff : person
{
    int staffID = 0;

    int choice = 0;
    int clientId = 0;


    public void staffStart()
    {

        Console.WriteLine("Enter Staff ID: ");
        staffID = Convert.ToInt32(Console.ReadLine());

        if (!File.Exists("s" + staffID))
        {
            Console.Write("Invalid Staff ID");
            staffStart();
        }

        else
        {

            Console.WriteLine("Choose action");

            Console.WriteLine("1 -- See client info");
            Console.WriteLine("2 -- Exit");

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                seeInfo(staffID);
            }

            else if (choice == 2)
            {
                Environment.Exit(0);
            }

        }
    }

    public void seeInfo(int staffID)
    {

        Console.WriteLine("Enter Client ID: ");
        clientId = Convert.ToInt32(Console.ReadLine());

        if (!File.Exists("h" + clientId))
        {
            Console.WriteLine("Client ID does not exist");
            seeInfo(staffID);
        }
        else
        {
            string fileContents = File.ReadAllText("h" + clientId);
            Console.WriteLine(fileContents);
            Console.WriteLine("1 -- Accept Request");
            Console.WriteLine("2 -- Decline Request");

            choice = Convert.ToInt32(Console.ReadLine());


            if (choice == 1)
            {

                FileStream f1 = new FileStream("h" + clientId, FileMode.Append);
                StreamWriter s1 = new StreamWriter(f1);
                s1.WriteLine("Completed by staff ID " + staffID);
                s1.Close();
                f1.Close();
                Console.WriteLine("Request Accepted!");

                File.Copy(@"h" + clientId, @"hc" + clientId);
                File.Delete("h"+clientId);



                seeInfo(staffID);
            }

            if (choice == 2)
            {
                seeInfo(staffID);




            }

        }



    }
}