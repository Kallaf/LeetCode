# @param {Integer[][]} matrix
# @return {Integer[]}
def spiral_order(matrix)
    dx = [0, 1, 0, -1]
    dy = [1, 0, -1, 0]
    n = matrix.length()
    m = matrix[0].length
    total = n * m
    visited = Array.new(n){Array.new(m)}
    ans = []
    i = 0; j = 0; k = 0
    for l in 1..total
        ans.push(matrix[i][j])
        visited[i][j] = true
        i += dx[k]; j += dy[k]
        if i == n || j == m || i == -1 || j == -1 || visited[i][j]
            i-=dx[k]; j-=dy[k]
            k = (k+1)%4
            i+=dx[k]; j+=dy[k]
        end
    end
    return ans
end
