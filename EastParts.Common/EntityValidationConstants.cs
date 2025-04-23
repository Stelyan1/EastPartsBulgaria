namespace EastParts.Common
{
    public class EntityValidationConstants
    {
        public static class CarBrand
        {
            public const byte CarBrandNameMaxLength = 40;
        }

        public static class CarBrandModels
        {
            public const byte CarBrandModelsNameMaxLength = 100;
        }

        public static class PartCategory
        {
            public const byte PartCategoryNameMaxLength = 100;
        }

        public static class PartType
        {
            public const byte PartTypeNameMaxLength = 100;
        }

        public static class Product 
        {
            public const byte ProductNameMaxLength = 60;
            public const byte ProductManufacturerMaxLength = 40;
            public const byte ProductDescriptionMaxLength = 250;
        }
    }
}
