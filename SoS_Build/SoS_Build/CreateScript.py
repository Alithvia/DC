import os

#Jeremy Power
#4/14/2018
#db_script_create.py

scriptList = ["CreateTable_luCountries.sql", "CreateTable_luProvinces.sql",
              "CreateTable_luCities.sql", "CreateTable_datVendors.sql",
              "CreateTable_datAddresses.sql", "CreateTable_jncVendorAddresses.sql",
              "CreateTable_luPositions.sql", "CreateTable_datEmployees.sql",
              "CreateTable_luPhoneTypes.sql", "CreateTable_datPhones.sql",
              "CreateTable_datPeople.sql", "CreateTable_luContactType.sql",
              "CreateTable_datContacts.sql", "CreateTable_jncEmployeeContacts.sql",
              "CreateTable_datClients.sql", "CreateTable_jncClientAddresses.sql",
              "CreateTable_jncClientContacts.sql", "CreateTable_datClientOrders.sql",
              "CreateTable_datTrays.sql", "CreateTable_datPackages.sql",
              "CreateTable_jncOrdersAndPackages.sql", "CreateTable_luVehicleTypes.sql",
              "CreateTable_datVehicles.sql", "CreateTable_datVehicleCleaning.sql",
              "CreateTable_datShipments.sql", "CreateTable_datPurchaseOrders.sql",
              "CreateTable_luUnits.sql", "CreateTable_luIngredients.sql",
              "CreateTable_datIngredientInventory.sql", "CreateTable_luAssemblyTypes.sql",
              "CreateTable_datAssembly.sql", "CreateTable_jncAssembly.sql",
              "CreateTable_datBoxes.sql", "CreateTable_luTimeTypes.sql",
              "CreateTable_HACCPTimes.sql", "CreateTable_HACCPTemps.sql",
              "CreateTable_datMeasurements.sql"]

bigScript = "CreateScript.sql"

try:
    os.remove(bigScript)
except OSError:
    pass
fileBigScript = open(bigScript, "a+")


for fileName in scriptList:
    currentScript = open(fileName, "r")
    fileBigScript.write(currentScript.read())
    currentScript.close()
    
fileBigScript.close()