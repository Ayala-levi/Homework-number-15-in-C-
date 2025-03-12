# שם הפרויקט - WebShop

## תיאור הפרויקט

פרויקט זה הוא יישום אינטרנטי לניהול רשימת מוצרים, עם ממשק משתמש ידידותי ואפשרויות להוספה, עדכון ומחיקה של מוצרים.
## תכונות עיקריות

* הצגת רשימת מוצרים עם פרטים כמו שם, מחיר ומלאי.
* אפשרות להוסיף מוצרים חדשים למערכת.
* אפשרות לעדכן פרטים של מוצרים קיימים.
* אפשרות למחוק מוצרים מהמערכת.
* ממשק משתמש אינטואיטיבי וקל לשימוש.
* מערכת התחברות משתמשים.
* API RESTful לניהול מוצרים.

## טכנולוגיות בשימוש

* **צד לקוח:** Visual Studio Code
* **צד שרת:** C# (Visual Studio)
* **מסד נתונים:** SQL

## דרישות מערכת

* **Visual Studio Code (גרסה מומלצת:** 1.85.1)
* **Visual Studio (גרסה מומלצת:** Visual Studio 2022)
* **SQL Server (גרסה מומלצת:** SQL Server 2019)
* **NET Framework (גרסה מומלצת:** .NET Framework 4.8)
* **ORM:** Entity Framework Core (EF Core)

## הוראות התקנה

1.  שכפל את המאגר (repository) לתיקייה מקומית:

    `git clone https://github.com/Ayala-levi/Homework-number-15-in-C-`

2.  פתח את פתרון Visual Studio (`.sln`) ב-Visual Studio.
3.  **תצורת מסד נתונים:**
    * עדכן את מחרוזת החיבור למסד הנתונים בקובץ `ShopDBContext.cs`.
    * ודא שמסד הנתונים SQL Server שלך פועל.
    * **Migrations:**
        * פתח את ה-Package Manager Console ב-Visual Studio.
        * הרץ את הפקודה `Update-Database` כדי ליצור או לעדכן את מסד הנתונים.

4.  בנה את הפרויקט (Build -> Build Solution) ב-Visual Studio.
5.  הרץ את הפרויקט (Debug -> Start Debugging) ב-Visual Studio.

