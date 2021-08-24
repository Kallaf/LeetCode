class Solution {
    public String complexNumberMultiply(String num1, String num2) {
        int real1 = getRealPart(num1);
        int real2 = getRealPart(num2);
        int imag1 = getImaginaryPart(num1);
        int imag2 = getImaginaryPart(num2);
        return toComplex(real1 * real2, real1 * imag2 + imag1 * real2, imag1 * imag2);
    }
    
    private int getRealPart(String num) {
        String real = num.split("\\+")[0];
        return Integer.parseInt(real);
    }
    
    private int getImaginaryPart(String num) {
        String imag = num.split("\\+")[1];
        return Integer.parseInt(imag.substring(0, imag.length() - 1));
    }
    
    private String toComplex(int real, int mix, int imag) {
        int realAns = real - imag;
        return String.valueOf(realAns) + "+" + String.valueOf(mix) + "i";
    }
    
}
