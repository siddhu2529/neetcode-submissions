public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var result = new int[temperatures.Length];
        for(int i=0; i<temperatures.Length; i++){
            var currentTemp = temperatures[i];
            for(int j=i; j<temperatures.Length; j++){
                if(temperatures[j]>currentTemp){
                    result[i] = j-i;
                    break;
                }
            }
        }
        return result;
    }
}
