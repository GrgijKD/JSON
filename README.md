Маємо файл з вмістом:
[
  {
    "PublishingHouseId": 2,
    "Title": "Підручник. Алгебра 8",
    "PublishingHouse": {
      "Id": 2,
      "Name": "ГІМНАЗІЯ",
      "Adress": "Адреса 2"
    }
  },
  {
    "PublishingHouseId": 1,
    "Title": "Щоденник нейрохірурга",
    "PublishingHouse": {
      "Id": 1,
      "Name": "Видавництво старого лева",
      "Adress": "Адреса 1"
    }
  },
  {
    "PublishingHouseId": 2,
    "Title": "Посібник. Алгебра 9",
    "PublishingHouse": {
      "Id": 2,
      "Name": "ГІМНАЗІЯ",
      "Adress": "Адреса 2"
    }
  }
]

Створити відповідні класи та десеріалізувати вміст файлу
Як необхідно змінити опис класів, щоб не серіалізувати в подальшому параметр PublishingHouseId ?
Як необхідно змінити опис класів, щоб серіалізований об’єкт містив параметр Title з назвою “Name” ?
