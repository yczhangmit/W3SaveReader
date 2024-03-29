﻿using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values.Journal
{
    public class CWitcherJournalManager /* : CJournalManager */
    {
        [CName("JObjectiveCounters")]
        public JObjectiveCounters ObjectiveCounters { get; set; }

        [CName("JTrackedQuest")]
        public JTrackedQuest TrackedQuest { get; set; }

        [CName("JHighlightedObjective")]
        public JHighlightedObjective HighlightedObjective { get; set; }

        [CName("JHuntingClues")]
        public JHuntingClues HuntingClues { get; set; }

        [CName("JMonsterKnown")]
        public JMonsterKnown MonsterKnown { get; set; }

        [CName("JEntryAdvancedInfo")]
        public JEntryAdvancedInfo EntryAdvancedInfo { get; set; }
    }
}