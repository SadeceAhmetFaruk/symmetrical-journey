// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld {
  public static string AntrepoYerlestir(string depoDurum, string[] gelenVagonlar) {
      
    // önce # dan sonraki bölümler kesilip F5 den sonraki depolara göre dağıtılacaklatır.depo durum burada belirlenecek
    string[] depodurumDizi = depoDurum.Split('#');
    char[] chars = subs[1].ToCharArray();

    // depo durum char to int çevirme
    int[] Intdepodurum = Array.ConvertAll(chars, c => (int) Char.GetNumericValue(c));

    // gelen vagonlar olarak bir matrix oluşturup oradan dizi işlemleri yapılacaktır.
    // String to Char
    char[][] Mchar;
    for (int i = 0; i < gelenVagonlar.length(); i++) {
      char[] chars = gelenVagonlar[i].ToCharArray();
      for (int j = 0; j < gelenVagonlar.length(); j++) {
        MChar[i][j] = chars[j];
      }
    }

    // Char to int 
    int[][] IChar;
      for (int i = 0; i < gelenVagonlar.length(); i++) {
      for (int j = 0; j < gelenVagonlar.length(); j++) {
        IChar[i][j] = MChar[j];
      }
    }
    // Kontrol ve Konveyora eklemek 
    for (int i = 0;i<IChar[i][j].length();i++){
        for (int j = 0 ; j<IChar[i][j].length();j++){
            if(Intdepodurum[i]<10 && Intdepodurum[i]>-1){
            int temp = 9 - Intdepodurum[i] ;
            IChar[i][j] =IChar[i][j] - temp;
            // Ichar yani vagonlarımız o a eşit değilse yan depoya geçer
            if(IChar[i][j]!=0){
            int temp = 9 - Intdepodurum[i++] ;
            IChar[i][j] =IChar[i][j] - temp;                }
            }
        }
    }
    // inr array to string
     string result = string.Join("", Intdepodurum);

    
    return result;
  }
  public static void Main(string[] args) {
      // deneme girişi 
    string s = "1#58819274817903720316326781253)";
    string[] subs = s.Split('#');
    char[] chars = subs[1].ToCharArray();

    Console.WriteLine("Original string: {0}", s);
    Console.WriteLine("Character array:");
    for (int ctr = 0; ctr < chars.Length; ctr++) {
      Console.WriteLine("   {0}: {1}", ctr, chars[ctr]);
    }
  }
}