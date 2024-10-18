class Fraction {
    private int _top;
    private int _bottom;

    public void Fractionate(){
        _top = 1;
        _bottom = 1;
    }

    public void Fractionate(int wholeNumber){
        _top = wholeNumber;
        _bottom = 1;
    }
    public void Fractionate(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }

// mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm

    public int GetTop(){
        return _top;
    }
    public void SetTop(int newTop){
        _top = newTop;
    }
    public int GetBottom(){
        return _bottom;
    }
    public void SetBottom(int newBottom){
        _bottom = newBottom;
    }

// mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm

    public string GetFractionString(){
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue(){
        return (double)_top / (double)_bottom;
    }
}