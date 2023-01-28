using System;
namespace LogicalPrograming
{
	public class CouponNumber
	{
		public static void GetCouponNumber()
		{
			int count = 0;
			int arrCount = 0;
			int[] arr = {10,32,42,65,29};

			Random random = new Random();
			while (arrCount != arr.Length)
			{
				int input = random.Next(0, 100);
				count++;
				switch (input)
				{
					case 10:
						arr[0] = 10;
						arrCount++;
						break;
                    case 32:
                        arr[1] = 32;
                        arrCount++;
                        break;
                    case 42:
                        arr[2] = 42;
                        arrCount++;
                        break;
                    case 65:
                        arr[3] = 65;
                        arrCount++;
                        break;
                    case 29:
                        arr[4] = 29;
                        arrCount++;
                        break;
                }
			}
			Console.WriteLine("\nCoupon Number are: ");
			for(int i = 0; i < arr.Length; i++)
			{
				Console.Write("{0}, ", (arr[i]));
			}
            Console.WriteLine("\nRandom number count: " + count + " in order Generate all distinct coupon numbers");
        }
	}
}

