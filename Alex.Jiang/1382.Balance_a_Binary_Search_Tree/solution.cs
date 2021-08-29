public TreeNode BalanceBST(TreeNode root) {
        List<int> nums = new List<int>();
        InOrder(root, nums);
        return ReOrder(nums, 0, nums.Count-1);
    }
    
    public void InOrder(TreeNode root, List<int> result){
        if(root == null)
            return;
        InOrder(root.left, result);
        result.Add(root.val);
        InOrder(root.right, result);
    }
    
    public TreeNode ReOrder(List<int> nums, int left, int right){
        if(left > right)
            return null;
        int mid = (right + left) / 2;
        TreeNode root = new TreeNode(nums[mid]);
        root.left = ReOrder(nums, left, mid -1);
        root.right = ReOrder(nums,mid+1,right);
        return root;
    }