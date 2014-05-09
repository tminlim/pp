using System;

public class NumPuzzle{
	public string name;
	private int [,] mData;
	private int mSize;
	private int xZero, yZero;

	public void init(int size){
		mSize = size;
		mData = new int[size,size];
		for (int i = 0; i < size; i++) {
			for (int j = 0; j < size; j++) {
				mData [i, j] = i * size + j + 1;
			}
		mData [size - 1, size - 1] = 0;
		xZero = yZero = size - 1;
		}
	}

	public string FindMove(){
		string ret = " ";
		//
		return ret;
	}

	public bool Move(int num){
		return false;
	}

	private void ZeroLocation(){
		for (int i = 0; i < mSize; i++) {
			for (int j = 0; j < mSize; j++) {
				if (mData [i, j] == 0) {
					xZero = i;
					yZero = j;
					return;
				}
			}
		}
	}

	private bool IsMove(int row, int col) {
		ZeroLocation ();
		if (!IsValid (row, col))
			return false;
		if ()
			return true;
	}

	private bool IsValid(int row, int col){
		return (0 <= row && 0 <= col && row < mSize && col < mSize);
	}

	private void swap(ref int a, ref int b){

	}
}

class Test {

}
