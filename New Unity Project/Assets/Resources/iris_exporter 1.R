

# This is just really simple code to export datasets and peek into their structure for export

# Remember to set working directory to source file location in R Studio
# ?write.csv()


# Export CSV, without quotes for strings
write.csv(iris, file = "iris.csv", quote = FALSE)

# Check max
max(iris$Sepal.Length)

max(iris[2])
max(iris[3])


# Sometimes row names are simply the index, so we don't need to export

write.csv(mtcars, file = "mtcars.csv", quote = FALSE, row.names = FALSE)


# Head is useful; shows the first 5 rows
head(airquality)

# Can set na's to something
write.csv(airquality, file = "airquality.csv", quote = FALSE, row.names = FALSE, na = "0")


