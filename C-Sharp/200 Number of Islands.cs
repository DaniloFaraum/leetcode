public class Solution
{
    public int NumIslands(char[][] grid)
    {
        if (grid.Length == 0 || grid[0].Length == 0) return 0;

        var count = 0;

        for (int i = 0; grid.Length > i; i++)
        {
            for (int j = 0; grid[0].Length > j; j++)
            {
                if (grid[i][j] == '1')
                {
                    count++;
                    dfs(grid, i, j);
                }
            }
        }
        return count;
    }

    public void dfs(char[][] grid, int i, int j)
    {
        if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length) return;

        if (grid[i][j] == '0') return;
        grid[i][j] = '0';

        dfs(grid, i + 1, j);
        dfs(grid, i - 1, j);
        dfs(grid, i, j + 1);
        dfs(grid, i , j - 1);
    }
}
