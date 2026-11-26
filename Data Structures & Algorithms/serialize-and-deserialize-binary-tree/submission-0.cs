/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }

    what is serialization -> 

        process of converting an in-memory structure
        into a sequence of bits so that in can be stored
        or sent across the network to be reconstructed later
        in a different computer env

        need to ensure that this bt can be serialized to a string
        and the string can be deserialized to the original
        tree

        the format can be different we need to turn it into a string then turn it back to normal
 */


public class Codec {
        // 1 2 3 null null 4 5
        //[1,2,3,#,#,4,5]
    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        StringBuilder sb = new StringBuilder();
        string rootval = ",";
        if(root == null) return "#";// since processing null case do not need if to check left and right + local variable initialize do not need to function scope it in if 
        rootval = root.val.ToString();
        
        string left = Serialize(root.left);
        string right = Serialize(root.right);

        sb.Append(rootval);
        sb.Append(',');
        sb.Append(left);
        sb.Append(',');
        sb.Append(right);

        return sb.ToString();

    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {

        Queue<string> q = new Queue<string>(data.Split(','));

        return Build(q);
        
    }
    public TreeNode Build(Queue<string> q){
        string token = q.Dequeue();
        if(token.Equals("#")) return null;
        TreeNode node =  new TreeNode(int.Parse(token));

        node.left = Build(q);
        node.right = Build(q);

        return node;
    }
}
