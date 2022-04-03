using System;

// ReverseStringSolution s = new ReverseStringSolution();
// char[] strNow = {'h','e','l','l','o'};
// s.ReverseString(strNow);

TwoSumSolution s = new TwoSumSolution();
int[] nums = {2,5,5,11};
int target = 10;
s.TwoSum(nums,target).ToList().ForEach(i => Console.WriteLine(i.ToString()));
