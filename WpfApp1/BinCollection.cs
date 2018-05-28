using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVV_SAMPLE01
{
    public class ScoreCollection : ObservableCollection<Score>
    {
        public ScoreCollection()
        {
            Add(new Score() { SUBJECT = "국어", SCORE = 95 });
            Add(new Score() { SUBJECT = "영어", SCORE = 55 });
            Add(new Score() { SUBJECT = "수학", SCORE = 65 });
        }
    }

    public class Score
    {
        public string SUBJECT { get; set; }
        public int SCORE { get; set; }
    }


}
