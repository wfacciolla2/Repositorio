package com.example.demo;

public class test {
    public static void main(String[] args) {
        int[][] meuArrayMulti = {{1,2,3,4},{5,6,7}};
        for (int i =0; i < meuArrayMulti.length; ++i){
            for (int j = 0; j < meuArrayMulti[i].length; ++j){
                System.out.println(meuArrayMulti[i][j]);
            }

        }
    }
}
