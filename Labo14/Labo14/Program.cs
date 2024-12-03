bool close = false;
List<string> names = new List<string>();

do {
    Console.Clear();
    Console.WriteLine("1. Voeg een naam toe");
    Console.WriteLine("2. Toon alle namen");
    Console.WriteLine("3. Zoek een naam");
    Console.WriteLine("4. Verwijder een naam");
    Console.WriteLine("5. Toon het aantal namen");
    Console.WriteLine("6. Stoppen");
    Console.Write("Kies een optie: ");

    string option = Console.ReadLine();
    string name;

        switch (option)
        {
            case "1":
                Console.Write("Naam: ");
                name = Console.ReadLine();

                if (!String.IsNullOrEmpty(name))
                {
                    names.Add(name);
                }
                break;

            case "2":
               // foreach(string s in names)
                //{
                  //  Console.WriteLine(s);
                //}
                Console.WriteLine(String.Join(Environment.NewLine, names));
                Console.ReadKey(true); //True erbij zetten laat de toets niet zien in de console.
                break;

            case "3":
                Console.Write("Naam: ");
                name= Console.ReadLine();
                int index = names.IndexOf(name);

                if (index == -1)
                {
                    Console.WriteLine($"{name} werd niet gevonden in de lijst.");
                }
                else
                {
                    Console.WriteLine($"{name} werd gevonden in de lijst op positie {index}");
                }
                Console.ReadKey(true);
                break;

            case "4":
                Console.Write("Naam: ");
                name = Console.ReadLine();
                    
                bool succes = names.Remove(name);
                if (succes)
                {
                    Console.WriteLine($"{name} werd succesvol verwijderd uit de lijst");
                }
                else
                {
                    Console.WriteLine($"{name} werd niet gevonden in de lijst.");
                }

                //names.RemoveAll(s => s.Equals(name));
                Console.ReadKey(true);
                break;

                case "5":
                    Console.WriteLine($"Momenteel bevat de lijst {names.Count} namen.");
                    Console.ReadKey(true);

                    break;

                case "6":
                    close = true;
                    break;
        }

} while (close == false) ;