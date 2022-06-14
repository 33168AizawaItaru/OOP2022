using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {

            _score = ReadScore(filePath);

        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {

            List<Student> scores = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                string[] items = line.Split(',');
                Student student
            }



        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {





            
        }
    }
}
