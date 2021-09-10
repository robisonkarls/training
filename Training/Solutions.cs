using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Training
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solutions
        {
            public static bool JudgeSquareSum(int c)
            {
                var right = (int)Math.Sqrt(c);
                var left = 0;
                while (left <= right)
                {
                    var sum = left * left + right * right;

                    if (sum == c)
                    {
                        return true;
                    }

                    if (sum < c)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }

                return false;
            }

            public static int RectangleArea(int[][] rectangles)
            {
                return default;
            }

            public static bool IsValidSerialization(string preorder)
            {
                var order = preorder.Split(",");

                if (order.Length % 2 == 0)
                {
                    return false;
                }

                var arrayLength = order.Length;

                if (1 == arrayLength)
                {
                    return order[0] == "#";
                }

                if (order[0] == "#")
                {
                    return false;
                }

                var previous = "";

                var emptyRightNode = 0;

                for (int i = 0; i < arrayLength; i++)
                {
                    if (order[i] == "#")
                    {
                        if (previous == "#")
                        {
                            emptyRightNode -= 1;
                        }

                        if (emptyRightNode == 0)
                        {
                            return i + 1 == arrayLength;
                        }

                        previous = "#";
                    }
                    else
                    {
                        if (previous != "#")
                        {
                            emptyRightNode += 1;
                        }

                        previous = order[i];
                    }
                }

                return true;
            }

            public static int FindMin(int[] nums)
            {
                if (nums.Length == 1) return nums[0];

                var left = 0;
                var right = nums.Length - 1;
                var val0 = nums[0];

                // no rotation.
                if (val0 < nums[right]) return val0;

                while (left < right)
                {
                    int mid = left + (right - left) / 2;
                    if (nums[mid] < val0)
                        right = mid;
                    else
                        left = mid + 1;
                }

                return nums[left];
            }

            public static IEnumerable<int> FindWheels(IReadOnlyList<int> wheels)
            {
                var result = new List<int>();

                foreach (var wheel in wheels)
                {
                    if (wheel % 2 == 0)
                    {
                        var numberOfCombinations = GetNumberOfCombinations(wheel);
                        
                        result.Add(numberOfCombinations);
                    }
                    else
                    {
                        result.Add(0);
                    }
                }
                
                return result;
            }

            private static int GetNumberOfCombinations(int wheel)
            {
                if (wheel == 2)
                {
                    return 1;
                }

                var combinations = wheel / 4;
                
                return combinations + 1;
            }
        }
    }