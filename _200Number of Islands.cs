using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _200Number_of_Islands
    {
        public int NumIslands(char[][] grid)
        {
            if (grid.Length == 0 || grid[0].Length == 0) return 0;
            int m = grid.Length, n = grid[0].Length, isLandCount = 0;
            var visited = new bool[m,n];
            for (var i = 0; i < m; ++i) {
                for (var j = 0; j < n; ++j) {
                    if (grid[i][j] == '0' || visited[i,j]) continue;
                    travelIsland(grid, visited, i, j);
                    ++isLandCount;
                }
            }
            return isLandCount;
        }
        
        private static void travelIsland(char[][] grid, bool[,] visited, int i, int j) {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == '0' || visited[i,j]) return;
            visited[i,j] = true;
            travelIsland(grid, visited, i - 1, j);
            travelIsland(grid, visited, i + 1, j);
            travelIsland(grid, visited, i, j - 1);
            travelIsland(grid, visited, i, j + 1);
        }
    }
}