public class CarLotInfo {

	public CarLotInfo(string salesPerson, string currentCar, string mostPopular) {
		SalesPersonOfTheMonth = salesPerson;
		CurrentCarOnSale = currentCar;
		MostPopularColorOnLot = mostPopular;
	}

	public string SalesPersonOfTheMonth { get; set; }
	public string CurrentCarOnSale { get; set; }
	public string MostPopularColorOnLot { get; set; }
}