using System;
using System.Collections.Generic;
using System.Linq;

namespace Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventIdToNames = new Dictionary<int, string>();
            var eventParticipant = new Dictionary<int, List<string>>();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Time for Code")
                {
                    break;
                }
                var commandParts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var eventId = 0;
                if (!int.TryParse(commandParts[0], out eventId))
                {
                    continue;
                }
                var eventName = commandParts[1];
                if (!eventName.StartsWith("#"))
                {
                    continue;
                }
                eventName = eventName.Trim('#');
                var invalidPart = false;
                var participants = new List<string>();
                
                for (int i = 2; i < commandParts.Length; i++)
                {
                    var participant = commandParts[i];
                    if (!commandParts[i].StartsWith("@"))
                    {
                        invalidPart = true;
                        break;
                    }
                    participants.Add(participant);
                }
                if (invalidPart)
                {
                    continue;
                }
                if (eventIdToNames.ContainsKey(eventId))
                {
                    var exciting = eventIdToNames[eventId];
                    if (exciting==eventName)
                    {
                        eventParticipant[eventId].AddRange(participants);
                    }
                }
                else
                {
                    eventIdToNames[eventId] = eventName;
                    eventParticipant[eventId] = new List<string>(participants);
                }
            }

            var events = eventParticipant
                .Select(kvp => new
                {
                    Id = kvp.Key,
                    Name = eventIdToNames[kvp.Key],
                    Participants = kvp.Value.
                    Distinct()
                    .OrderBy(p=>p)
                    .ToList()
                }).
                OrderByDescending(kvp => kvp.Participants.Count)
                .ThenBy(ev => ev.Name).ToList();

            foreach (var ev in events)
            {
                var eventId = ev.Id;
                var evenName = ev.Name;
                var participants = ev.Participants;
                Console.WriteLine($"{evenName} - {participants.Count}");
                foreach (var part in participants)
                {
                    Console.WriteLine(part);
                }
            }
        }
    }
}
