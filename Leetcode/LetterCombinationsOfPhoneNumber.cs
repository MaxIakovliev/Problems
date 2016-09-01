using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    /// <summary>
    /// https://leetcode.com/problems/letter-combinations-of-a-phone-number/
    /// </summary>
    public class LetterCombinationsOfPhoneNumber
    {
        public IList<string> Solution1(string digits)
        {
            var dict = new Dictionary<char, string>(){
            {'2',"abc"},{'3', "def"}, {'4', "ghi"},{'5', "jkl"},{'6', "mno"},{'7', "pqrs"},{'8', "tuv"},{'9', "wxyz"}};

            var result = new List<string>();
            if (string.IsNullOrEmpty(digits)) return result;

            for (int i = 0; i < digits.Length; i++) //walk through  input string
            {
                if (!dict.ContainsKey(digits[i])) continue;
                var bucket = dict[digits[i]]; //pick bucket  based on current digit

                if (result.Count() == 0) //if result is not exists yet-  distribute  letters from current bucket
                {
                    for (int j = 0; j < bucket.Length; j++)
                        result.Add(bucket[j].ToString());
                    continue;
                }

                for (int j = 0; j < result.Count(); j++)//walk through  result
                {
                    if (result[j].Length >= i + 1) continue; //prevent duplications

                    bool updatedFirst = false;
                    var template = result[j];
                    for (int k = 0; k < bucket.Length; k++) //walk through  selected bucket
                    {
                        if (!updatedFirst) //update first record only
                        {
                            result[j] = result[j] + bucket[k].ToString();
                            updatedFirst = true;
                        }
                        else 
                        {
                            result.Add(template + bucket[k]); //adding new combinations to result
                        }
                    }

                }
            }

            return result;
        }
    }
}
