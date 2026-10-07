while (true) // infinite iteration
{
	System.Console.WriteLine("\n**** Welcome to Cinema Menu *****");
	System.Console.WriteLine("1. One person's cinema price");
	System.Console.WriteLine("2. Group cinema price");
	System.Console.WriteLine("3. Repeat text 10 times");
	System.Console.WriteLine("4. Get third word");
	System.Console.WriteLine("0. Exit");
	System.Console.Write("Enter your choice: ");

	string choice = Console.ReadLine()!; // null-forgiving operator for compiler 

	switch (choice)
	{
		case "1":
			while (true)
			{
				System.Console.Write("Enter your age: ");
				string inputAge = Console.ReadLine()!;

				// input validation: the input is null, empty string (ENTER), tabs, spaces. Validate null or whitespace-only input.
				if (string.IsNullOrWhiteSpace(inputAge))
				{
					System.Console.WriteLine("Invalid age, enter a number");
					continue;
				}

				// TryParse: the age is a valid integer.
				if (int.TryParse(inputAge, out int age))
				{
					System.Console.WriteLine("Age= " + age);


					// Nested if: if-else -> if-else 
					if (age < 20)
					{
						System.Console.WriteLine("Youth price: 80 SEK");
					}
					else
					{
						if (age > 64)
						{
							System.Console.WriteLine("Pensioner price: 90 SEK");
						}
						else
						{
							System.Console.WriteLine("Standard price: 120 SEK");
						}
					}
					break;
				}
				else
				{
					System.Console.WriteLine("Invalid age, enter a number");
					continue;
				}
			}
			break;

		case "2":
			System.Console.Write("Enter number of people: ");
			string inputAmountOfPeople = Console.ReadLine()!;

			// input validation: the input is null, empty string (ENTER), tabs, spaces. Validate null or whitespace-only input.
			if (string.IsNullOrWhiteSpace(inputAmountOfPeople))
			{
				System.Console.WriteLine("Invalid amount of people, enter a number");
				continue;
			}

			// TryParse: the amount of people is a valid integer.
			if (int.TryParse(inputAmountOfPeople, out int amountOfPeople))
			{
				System.Console.WriteLine("Number of people: " + amountOfPeople);

				List<int> ageList = new List<int>();

				for (int count = 1; count <= amountOfPeople; count++)
				{
					System.Console.Write($"Enter age for person {count}: ");
					string inputAge = Console.ReadLine()!;

					if (string.IsNullOrWhiteSpace(inputAge))
					{
						System.Console.WriteLine("Invalid age, enter a number");
						count--;
						continue;
					}

					if (int.TryParse(inputAge, out int intAge))
					{
						ageList.Add(intAge);
						System.Console.WriteLine($"Age person {count} = {ageList[count - 1]}");
					}
					else
					{
						System.Console.WriteLine("Invalid age, enter a number");
						count--;
					}
				}

				int totalCost = 0;
				foreach (int age in ageList)
				{
					if (age < 20)
					{
						totalCost += 80;
					}
					else if (age > 64)
					{
						totalCost += 90;
					}
					else
					{
						totalCost += 120;
					}
				}
				System.Console.WriteLine($"Group cinema price : {totalCost} SEK");
			}
			break;

		case "3":
			System.Console.Write("Enter any text: ");
			string text = Console.ReadLine()!;
			for (int i = 1; i <= 10; i++)
			{
				Console.Write($"{i}. {text}, ");
			}
			System.Console.WriteLine("");
			break;

		case "4":
			while (true)
			{
				System.Console.Write("Enter your sentence: ");
				string sentence = Console.ReadLine()!;
				string[] word = sentence.Split(' ');
				if (word.Length < 3)
				{
					System.Console.WriteLine("Please enter at least 3 words.");
					continue;
				}
				System.Console.WriteLine($"{word[2]}");
				break;
			}
			break;
		case "0":
			System.Console.WriteLine("\n\tGood bye and come back soon to Cinema!");
			return;

		default:
			System.Console.WriteLine("Invalid choice. Select 1, 2 or 0");
			break;
	}
}
