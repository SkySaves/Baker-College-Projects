Public Class DailyLog
    Public Property LogDate As Date
    Public Property Foods As List(Of ConsumedFood)
End Class

Public Class ConsumedFood
    Public Property MealCategory As String
    Public Property FoodName As String
    Public Property ServingDescription As String
    Public Property Calories As Double
    Public Property Protein As Double
    Public Property Carbs As Double
    Public Property Fat As Double
End Class
