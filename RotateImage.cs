public void Rotate(int[][] matrix) {
    if(matrix == null || matrix.Length == 0 || matrix[0].Length == 0) return;
    int rows = matrix.Length;
    int cols = matrix[0].Length;
    for(int first=0, last=rows-1; first<last; first++,last--) {
        int[] tmp = matrix[first];
        matrix[first] = matrix[last];
        matrix[last] = tmp;
    }
    for(int i = 0; i < rows; i++){
        for(int j = i+1; j < cols; j++){
            int tmp = matrix[i][j];
            matrix[i][j] = matrix[j][i];
            matrix[j][i] = tmp;
        }
    }
}