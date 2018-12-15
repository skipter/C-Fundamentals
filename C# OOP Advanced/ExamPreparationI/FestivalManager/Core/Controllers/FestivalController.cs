﻿namespace FestivalManager.Core.Controllers
{
    using System;
    using System.Linq;
    using System.Text;
    using Contracts;
    using Entities.Contracts;
    using FestivalManager.Entities;
    using FestivalManager.Entities.Factories.Contracts;

    public class FestivalController : IFestivalController
    {
        private const string TimeFormat = "mm\\:ss";
        private const string TimeFormatLong = "{0:2D}:{1:2D}";
        private const string TimeFormatThreeDimensional = "{0:3D}:{1:3D}";

        private readonly IStage stage;
        private readonly ISetFactory setFactory;
        private readonly IInstrumentFactory instrumentFactory;

        public FestivalController(IStage stage, ISetFactory setFactory, IInstrumentFactory instrumentFactory)
        {
            this.stage = stage;
            this.setFactory = setFactory; //or new SetFactory();
            this.instrumentFactory = instrumentFactory;
        }

        public string ProduceReport()
        {
            StringBuilder sb = new StringBuilder(); 

            var totalFestivalLength = new TimeSpan(this.stage.Sets.Sum(s => s.ActualDuration.Ticks));

            sb.AppendLine($"Festival length: {totalFestivalLength.ToString(TimeFormat)}");

            foreach (var set in this.stage.Sets)
            {
                sb.AppendLine($"--{set.Name} ({totalFestivalLength.ToString(TimeFormat)}):");

                var performersOrderedDescendingByAge = set.Performers.OrderByDescending(p => p.Age);
                foreach (var performer in performersOrderedDescendingByAge)
                {
                    var instruments = string.Join(", ", performer.Instruments
                        .OrderByDescending(i => i.Wear));

                    sb.AppendLine($"---{performer.Name} ({instruments})");
                }

                if (!set.Songs.Any())
                    sb.AppendLine("--No songs played");
                else
                {
                    sb.AppendLine("--Songs played:");
                    foreach (var song in set.Songs)
                    {
                        sb.AppendLine($"----{song.Name} ({song.Duration.ToString(TimeFormat)})");
                    }
                }
            }

            return sb.ToString();
        }

        public string RegisterSet(string[] args)
        {
            string name = args[0];
            string setTypeName = args[1];

            ISet set = this.setFactory.CreateSet(name, setTypeName);

            this.stage.AddSet(set);

            string result = $"Registered {setTypeName} set";
            return result;
        }

        public string SignUpPerformer(string[] args)
        {
            var name = args[0];
            var age = int.Parse(args[1]);

            var instrumentNames = args.Skip(2).ToArray();

            var instruments = instrumentNames
                .Select(i => this.instrumentFactory.CreateInstrument(i))
                .ToArray();

            IPerformer performer = new Performer(name, age);

            foreach (IInstrument instrument in instruments)
            {
                performer.AddInstrument(instrument);
            }

            this.stage.AddPerformer(performer);

            return $"Registered performer {performer.Name}";
        }

        public string RegisterSong(string[] args)
        {
            string songName = args[0];
            int[] songDurationTokens = args[1]
                .Split(':')
                .Select(int.Parse)
                .ToArray();

            int songMinutes = songDurationTokens[0];
            int songSeconds = songDurationTokens[1];

            TimeSpan songDuration = new TimeSpan(0, songMinutes, songSeconds);

            ISong song = new Song(songName, songDuration);

            this.stage.AddSong(song);

            return $"Registered song {song}";
        }

        public string AddPerformerToSet(string[] args)
        {
            var performerName = args[0];
            var setName = args[1];

            if (!this.stage.HasPerformer(performerName))
            {
                throw new InvalidOperationException("Invalid performer provided");
            }

            if (!this.stage.HasSet(setName))
            {
                throw new InvalidOperationException("Invalid set provided");
            }

            var performer = this.stage.GetPerformer(performerName);
            var set = this.stage.GetSet(setName);

            set.AddPerformer(performer);

            return $"Added {performer.Name} to {set.Name}";
        }

        public string AddSongToSet(string[] args)
        {
            var songName = args[0];
            var setName = args[1];

            if (!this.stage.HasSet(setName))
            {
                throw new InvalidOperationException("Invalid set provided");
            }

            if (!this.stage.HasSong(songName))
            {
                throw new InvalidOperationException("Invalid song provided");
            }

            var set = this.stage.GetSet(setName);
            var song = this.stage.GetSong(songName);

            set.AddSong(song);

            return $"Added {song} to {set.Name}";
        }

        public string RepairInstruments(string[] args)
        {
            var instrumentsToRepair = this.stage.Performers
                .SelectMany(p => p.Instruments)
                .Where(i => i.Wear < 100)
                .ToArray();

            foreach (var instrument in instrumentsToRepair)
            {
                instrument.Repair();
            }

            return $"Repaired {instrumentsToRepair.Length} instruments";
        }
    }
}