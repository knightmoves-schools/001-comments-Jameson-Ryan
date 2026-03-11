namespace km__c_sharp__001_comments;
public class TotalCalculator
{   
    public int Calculate(){
        int total = 50;

        total = total - 1;
        // total = total - 2;
        total = total - 3;
        /* total = total - 4;
        total = total - 5;
        total = total - 6; */
        total = total - 7;

        return total;
    }
}

/* should contain a single line comment that comments out line 8  (total = total - 2;)
should contain a multi-line comment that comments out lines 10, 11 and 12 (total = total - 4;, total = total - 5; and total = total - 6;)
should return 39
*/
