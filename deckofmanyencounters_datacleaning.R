library(tidyverse)

data <- read.csv("C:\\Users\\chris\\OneDrive - Washington State University (email.wsu.edu)\\School Stuff\\hackathon 2025\\Monster Spreadsheet (D&D5e) - Official Stats.csv")

data <- data %>%
  mutate(realm = if_else(data$Type == "Fiend", "Nine Hells", "Other")) %>%
  mutate(realm = if_else(data$Type == "Fey", "Feywild", realm)) %>%
  mutate(realm = if_else(data$Type == "Elemental", "Elemental Plane", realm)) %>%
  mutate(realm = if_else(data$Type == "Celestial", "Astral Plane", realm)) %>%
  mutate(has_fly_speed = if_else(grepl("fly", data$Speeds), 1, 0)) %>%
  mutate(has_swim_speed = if_else(grepl("swim", data$Speeds), 1, 0))

write.csv(data, "C:\\Users\\chris\\OneDrive - Washington State University (email.wsu.edu)\\School Stuff\\hackathon 2025\\datafile.csv")
