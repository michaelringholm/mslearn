
using System;
using System.Collections.Generic;

namespace dk.commentor.mslearn.web
{
    // {"totalPoints":0,"level":{"levelNumber":1,"pointsLow":0,"pointsHigh":1799},"levelAchievedDateUTC":null,"nextLevelNumber":2,"currentLevelPointsEarned":0,"pointsToNextLevel":1800,"achievements":[]}
    public class Gamer
    {
        public String totalPoints { get; set; }        
        public String level { get; set; }
        public String levelNumber { get; set; }
        public String pointsLow { get; set; }
        public String pointsHigh { get; set; }
        public String levelAchievedDateUTC { get; set; }
        public String nextLevelNumber { get; set; }
        public String currentLevelPointsEarned { get; set; }
        public String pointsToNextLevel { get; set; }
        public List<String> achievements { get; set; }
    }
}