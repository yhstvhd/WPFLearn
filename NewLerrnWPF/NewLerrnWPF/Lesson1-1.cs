/*
 * http://ufcpp.net/study/csharp/st_comment.html
 * 日付: 2017/09/20
 * 時刻: 22:31
 * 
 * このテンプレートを変更する場合「ツール→オプション→コーディング→標準ヘッダの編集」
 */
using System;

//クラスの前にはその説明を書いたほうがいい

//「///」ではじまるコメントはC#では特別な意味を持つ
//またあとでね

///<summary>
///コメント付けのプログラム
///ここでは例として配列で与えられたデータ列の平均値と分散を求めて表示する。
///</summary>

class Lesson1_1
{
	static void Main()
	{
		//変数名のあとに変数の説明を書いたりすることも
		//本当は、コメントが無くても意味のわかる変数名をつけるべき
		
		var detaSource = new[] {
			455, 58, 8, 7, 987, 56, 2 , 64 , 698, 79,
			98, 79, 45, 465, 167, 97, 94, 657, 237, 587,
			687, 654, 647, 4, 654, 984, 8, 489, 7, 22}; //データ列
		double mean; //平均値
		double variance; //分散
		
		//コメントは関数の上にあればいいというのが理想
		//dataSourceの平均を求める
		CalcMean(detaSource, out mean , out variance);
		
		Console.WriteLine("平均：{0}, 分散：{1}", mean ,variance);
		Console.ReadKey();
	}
	
	/// <summary>
	/// 配列に入ったデータの平均値と分散を求める
	/// <param name="data">与えられたデータ列</param>
	/// <param name="mean">dataの平均値(出力)</param>
	/// <param name="variance">dataの分散(出力)</param>
	/// </summary>

	static void CalcMean(int[] data, out double mean, out double variance)
	{
		int sum = 0; 
		int sq_sum = 0; //二乗の合計
		
		//データ列の合計と二乗の合計を求める
		foreach(int n in data)
		{
			sum += n;
			sq_sum += n*n;
		}
		
		//平均と分散を計算
		mean = (double)sum / data.Length;
		variance = (double)sq_sum / data.Length - mean*mean;
	}
}