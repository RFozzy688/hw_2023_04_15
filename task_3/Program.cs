//Подсчитать, сколько раз каждое слово встречается в заданном тексте . Результат записать в коллекцию 
//Dictionary<TKey, TValue>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Lorem Ipsum - это текст-\"рыба\", часто используемый в печати и вэб-дизайне. " +
                "Lorem Ipsum является стандартной \"рыбой\" для текстов на латинице с начала XVI века. " +
                "В то время некий безымянный печатник создал большую коллекцию размеров и форм шрифтов, " +
                "используя Lorem Ipsum для распечатки образцов. Lorem Ipsum не только успешно пережил без " +
                "заметных изменений пять веков, но и перешагнул в электронный дизайн. Его популяризации в " +
                "новое время послужили публикация листов Letraset с образцами Lorem Ipsum в 60-х годах и, в " +
                "более недавнее время, программы электронной вёрстки типа Aldus PageMaker, в шаблонах которых " +
                "используется Lorem Ipsum.";
            char[] separators = { ',', ' ', '.', '-' };
            string[] words = str.Split(separators);

            Dictionary<string, int> map = new Dictionary<string, int>();
            
            foreach (string word in words)
            {
                if (word != "")
                {
                    if (map.ContainsKey(word) == false)
                    {
                        map.Add(word, 1);
                    }
                    else
                    {
                        map[word] += 1;
                    }
                }
            }

            foreach (var item in map.Keys)
            {
                Console.WriteLine($"{item}: {map[item]}");
            }
        }
    }
}
