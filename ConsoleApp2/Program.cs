using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

record Client(string PIB, string BankName, int Money);

class Program
{
    static void Main(string[] args)
    {
        System.Console.OutputEncoding = Encoding.UTF8;

        List<Client> clients = new List<Client>();

        clients.Add(new Client("Iванов Iван Iванович", "Приватбанк", 5000000));
        clients.Add(new Client("Петров Петро Петрович", "Монобанк", 84000));
        clients.Add(new Client("Васильєв Василь Васильович", "Приватбанк", 18500));
        clients.Add(new Client("Вiкторов Вiктор Вiкторович", "А-Банк", 1000));
        clients.Add(new Client("Хтось хтось хтось", "ПУМБ", 12000000));
        clients.Add(new Client("Пономаренко Iван Сергiйович", "Монобанк", 1200000));
        clients.Add(new Client("Крамарчук Євгенiя Андрiївна", "Приватбанк", 1200000));
        clients.Add(new Client("Кравчук Микола Васильович", "ПУМБ", 11520000));
        clients.Add(new Client("Шинкаренко В'ячеслав Iванович", "Монобанк", 1200000));
        clients.Add(new Client("Мiрошниченко Григорiй Євгенiйович", "ПУМБ", 120000000));
        clients.Add(new Client("Мельниченко Денис Олексiйович", "Монобанк", 5200000));
        clients.Add(new Client("Васильєв Болеслав Валентинович", "Приватбанк", 886000));
        clients.Add(new Client("Лисенко Валентин Володимирович", "ПУМБ", 45000000));
        clients.Add(new Client("Петров Данило Михайлович", "Монобанк", 8000000));
        clients.Add(new Client("Iванова Катерина Борисiвна", "Приватбанк", 6000000));



        var millionairesByBank = clients.GroupBy(c => c.BankName)
                                        .Select(g => new
                                        {
                                            BankName = g.Key,
                                            Millionaires = g.Where(c => c.Money >= 1000000)
                                        });

        foreach (var bankGroup in millionairesByBank)
        {
            Console.WriteLine($"Банк: {bankGroup.BankName}");
            foreach (var millionaire in bankGroup.Millionaires)
            {
                Console.WriteLine($"Клiєнт: {millionaire.PIB}, Баланс: {millionaire.Money:C}");
            }

            Console.WriteLine();
        }
    }
}


