

        // Add some more integers to the list
        // Iterate over the list and write only odd numbers to the console
        // The output should be on the same line.

        List<int> numbers = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
            numbers.Add(23);
            numbers.Add(27);
            numbers.Add(29);
            numbers.Add(35);
        foreach(int number in numbers) {
            if(number % 2 != 0) {
                Console.WriteLine(number);
            }
        }

        Console.WriteLine(" ");

        Dictionary<string, int> transports = new Dictionary<string, int>(){
            {"bicycle", 2}};
            transports.Add("car", 5);
            transports.Add("bus", 7);
            transports.Add("skateboard", 10);

        foreach(KeyValuePair<string, int> transportType in transports){
            Console.WriteLine($"A {transportType.Key} has {transportType.Value} wheels");
        }