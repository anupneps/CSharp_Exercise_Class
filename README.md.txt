1. Defining a class to represent a country. Each country has the following:

    - Name
    - Population (millions of people)
    - Region (such as: Western Europe, East Asia etc)
    - Capital
    - GDP
    - An array of languages which has the following details:
        - Name
        - IsPrimary (If the language is the main language)
    - An array of cities where each has:
        - Name
        - IsCapital (If the city is the capital)
    - Population
    - List of countries that border with this country

2. Defining these methods:

    - HasBorder: Check if a country has border with another country, given the country name or a country object (use overloading)
    - Indexer methods to get back cities/city of the country
    - CheckWealth: Get the country’s wealthiness level (use an enum, such as: SuperPoor, Poor, Medium, Rich, SuperRich) based on the GDP per capita - GDPP (you define the range freely)
NOTES:
You may need to define extra classes/structs to represent different entity/object types (think about real life)
Use method overloading if needed
When defining properties, think about what should be: readonly, init-only or with private setter.