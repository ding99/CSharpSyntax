namespace LinqExpressions {
	class ProductInfo {
		public string Name { get; set; } = "";
		public string Desc { get; set; } = "";
		public int Number { get; set; } = 0;
		public override string ToString() {
			return $"Name={Name}, Desc={Desc}, Number in Stock={Number}";
		}
	}
}
