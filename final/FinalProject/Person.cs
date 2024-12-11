abstract class Person{
    public List<Card> _hand = [];

    public abstract void SelectHand(List<string> cardList);
    public abstract Card SelectCard( string selectedCard);
    
    public bool HasHand(){
        foreach(Card card in _hand){
            if (card.IsAlive()){
                return true;
            }
        }
        return false;
    }


}