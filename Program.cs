Console.Write("Enter the day of the week number (1-7): ");
if (int.TryParse(Console.ReadLine(), out int dayNumber))
    Console.WriteLine(dayNumber 
        switch
    {
        1 => "Monday",
        2 => "Tuesday",
        3 => "Wednesday",
        4 => "Thursday",
        5 => "Friday",
        6 => "Saturday",
        7 => "Sunday",
    });
