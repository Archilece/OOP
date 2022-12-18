using System;
using System.IO;

class programStart
{
    public static void Main(string[] args)
    {

        int choice = 0;
        superAdmin spA = new superAdmin();
        Manager mng = new Manager();
        client clt = new client();
        Staff stf = new Staff();
        Console.WriteLine("Control User");
        Console.WriteLine("=====================================");
        Console.WriteLine("Super Admin [1] - Manager [2] - Staff [3] - Client [4]");
        Console.WriteLine("=====================================");
        choice = Convert.ToInt16(Console.ReadLine());

        switch (choice)
        {
            case 1:
                spA.superAdminStart();
                break;

            case 2:
                mng.managerStart();
                break;

            case 3:
                stf.staffStart();

                break;

            case 4:
                clt.clientStart();
                break;

        }
    }

}