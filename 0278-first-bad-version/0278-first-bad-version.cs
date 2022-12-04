/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    
    
    public int FirstBadVersion(int n) {
        
        int s=1,e=n,bad=1;

        
        while(s<=e){   
          int m=s+(e-s)/2;  
          if(IsBadVersion(m))
            {
              bad=m;
                e=m-1;
            }
            else{
                s=m+1;
            }
        }
        return bad;
    }
}