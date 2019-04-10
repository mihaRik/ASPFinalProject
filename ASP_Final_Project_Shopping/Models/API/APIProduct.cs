using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project_Shopping.Models.API
{
    public class APIProduct
    {
        public class RelatedProduct
        {
            public int sku { get; set; }
        }

        public class CategoryPath
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        public class Shipping
        {
            public string ground { get; set; }
            public int secondDay { get; set; }
            public double nextDay { get; set; }
            public string vendorDelivery { get; set; }
        }

        public class ShippingLevelsOfService
        {
            public int serviceLevelId { get; set; }
            public string serviceLevelName { get; set; }
            public double unitShippingPrice { get; set; }
        }

        public class Image
        {
            public string rel { get; set; }
            public string unitOfMeasure { get; set; }
            public string width { get; set; }
            public string height { get; set; }
            public string href { get; set; }
        }

        public class IncludedItemList
        {
            public string includedItem { get; set; }
        }

        public class Product
        {
            public int sku { get; set; }
            public object score { get; set; }
            public long? productId { get; set; }
            public string name { get; set; }
            public string source { get; set; }
            public string type { get; set; }
            public string startDate { get; set; }
            public bool? @new { get; set; }
            public bool? active { get; set; }
            public bool? lowPriceGuarantee { get; set; }
            public DateTime activeUpdateDate { get; set; }
            public double? regularPrice { get; set; }
            public double? salePrice { get; set; }
            public bool? clearance { get; set; }
            public bool? onSale { get; set; }
            public object planPrice { get; set; }
            public List<object> priceWithPlan { get; set; }
            public List<object> contracts { get; set; }
            public object priceRestriction { get; set; }
            public DateTime priceUpdateDate { get; set; }
            public bool? digital { get; set; }
            public bool? preowned { get; set; }
            public List<object> carriers { get; set; }
            public List<object> planFeatures { get; set; }
            public List<object> devices { get; set; }
            public List<object> carrierPlans { get; set; }
            public object technologyCode { get; set; }
            public object carrierModelNumber { get; set; }
            public List<object> earlyTerminationFees { get; set; }
            public string monthlyRecurringCharge { get; set; }
            public string monthlyRecurringChargeGrandTotal { get; set; }
            public string activationCharge { get; set; }
            public string minutePrice { get; set; }
            public object planCategory { get; set; }
            public object planType { get; set; }
            public object familyIndividualCode { get; set; }
            public object validFrom { get; set; }
            public object validUntil { get; set; }
            public object carrierPlan { get; set; }
            public object outletCenter { get; set; }
            public object secondaryMarket { get; set; }
            public List<object> frequentlyPurchasedWith { get; set; }
            public List<object> accessories { get; set; }
            public List<object> relatedProducts { get; set; }
            public List<object> requiredParts { get; set; }
            public List<object> techSupportPlans { get; set; }
            public List<object> crossSell { get; set; }
            public int? salesRankShortTerm { get; set; }
            public int? salesRankMediumTerm { get; set; }
            public int? salesRankLongTerm { get; set; }
            public int? bestSellingRank { get; set; }
            public string url { get; set; }
            public object spin360Url { get; set; }
            public string mobileUrl { get; set; }
            public object affiliateUrl { get; set; }
            public string addToCartUrl { get; set; }
            public object affiliateAddToCartUrl { get; set; }
            public string linkShareAffiliateUrl { get; set; }
            public string linkShareAffiliateAddToCartUrl { get; set; }
            public string upc { get; set; }
            public string productTemplate { get; set; }
            public List<CategoryPath> categoryPath { get; set; }
            public List<object> alternateCategories { get; set; }
            public List<object> lists { get; set; }
            public int? customerReviewCount { get; set; }
            public double? customerReviewAverage { get; set; }
            public bool? customerTopRated { get; set; }
            public string format { get; set; }
            public bool? freeShipping { get; set; }
            public bool? freeShippingEligible { get; set; }
            public bool? inStoreAvailability { get; set; }
            public string inStoreAvailabilityText { get; set; }
            public DateTime inStoreAvailabilityUpdateDate { get; set; }
            public DateTime itemUpdateDate { get; set; }
            public bool? onlineAvailability { get; set; }
            public string onlineAvailabilityText { get; set; }
            public DateTime onlineAvailabilityUpdateDate { get; set; }
            public string releaseDate { get; set; }
            public object shippingCost { get; set; }
            public List<object> shipping { get; set; }
            public List<object> shippingLevelsOfService { get; set; }
            public bool? specialOrder { get; set; }
            public string shortDescription { get; set; }
            public string @class { get; set; }
            public int? classId { get; set; }
            public string subclass { get; set; }
            public int? subclassId { get; set; }
            public string department { get; set; }
            public int? departmentId { get; set; }
            public string protectionPlanTerm { get; set; }
            public string protectionPlanType { get; set; }
            public string protectionPlanLowPrice { get; set; }
            public string protectionPlanHighPrice { get; set; }
            public List<object> buybackPlans { get; set; }
            public List<object> protectionPlans { get; set; }
            public List<object> protectionPlanDetails { get; set; }
            public List<object> productFamilies { get; set; }
            public List<object> productVariations { get; set; }
            public object aspectRatio { get; set; }
            public string screenFormat { get; set; }
            public int? lengthInMinutes { get; set; }
            public string mpaaRating { get; set; }
            public string plot { get; set; }
            public string studio { get; set; }
            public string theatricalReleaseDate { get; set; }
            public object description { get; set; }
            public string manufacturer { get; set; }
            public string modelNumber { get; set; }
            public List<Image> images { get; set; }
            public string image { get; set; }
            public string largeFrontImage { get; set; }
            public string mediumImage { get; set; }
            public string thumbnailImage { get; set; }
            public string largeImage { get; set; }
            public string alternateViewsImage { get; set; }
            public string angleImage { get; set; }
            public object backViewImage { get; set; }
            public object energyGuideImage { get; set; }
            public object leftViewImage { get; set; }
            public object accessoriesImage { get; set; }
            public object remoteControlImage { get; set; }
            public object rightViewImage { get; set; }
            public object topViewImage { get; set; }
            public string albumTitle { get; set; }
            public string artistName { get; set; }
            public object artistId { get; set; }
            public string originalReleaseDate { get; set; }
            public bool? parentalAdvisory { get; set; }
            public object mediaCount { get; set; }
            public object monoStereo { get; set; }
            public object studioLive { get; set; }
            public string condition { get; set; }
            public bool? inStorePickup { get; set; }
            public bool? friendsAndFamilyPickup { get; set; }
            public bool? homeDelivery { get; set; }
            public int? quantityLimit { get; set; }
            public string fulfilledBy { get; set; }
            public List<object> members { get; set; }
            public List<object> bundledIn { get; set; }
            public string albumLabel { get; set; }
            public string genre { get; set; }
            public string color { get; set; }
            public string depth { get; set; }
            public int? dollarSavings { get; set; }
            public string percentSavings { get; set; }
            public string tradeInValue { get; set; }
            public string height { get; set; }
            public string orderable { get; set; }
            public string weight { get; set; }
            public double? shippingWeight { get; set; }
            public string width { get; set; }
            public string warrantyLabor { get; set; }
            public string warrantyParts { get; set; }
            public object softwareAge { get; set; }
            public object softwareGrade { get; set; }
            public string platform { get; set; }
            public object numberOfPlayers { get; set; }
            public object softwareNumberOfPlayers { get; set; }
            public string esrbRating { get; set; }
            public string longDescription { get; set; }
            public List<object> includedItemList { get; set; }
            public bool? marketplace { get; set; }
            public object listingId { get; set; }
            public object sellerId { get; set; }
            public object shippingRestrictions { get; set; }
            public object proposition65WarningMessage { get; set; }
            public string proposition65WarningType { get; set; }
            public string productAspectRatio { get; set; }
            public bool? headphoneJacks { get; set; }
            public bool? energyStarQualified { get; set; }
            public int? peakPowerHandling { get; set; }
        }

        public class CustomAPIProduct
        {
            public int from { get; set; }
            public int to { get; set; }
            public int currentPage { get; set; }
            public int total { get; set; }
            public int totalPages { get; set; }
            public string queryTime { get; set; }
            public string totalTime { get; set; }
            public bool partial { get; set; }
            public string canonicalUrl { get; set; }
            public List<Product> products { get; set; }
        }
    }
}
