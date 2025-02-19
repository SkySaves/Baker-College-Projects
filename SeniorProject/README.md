# 2-in-1 Workout & Nutrition Tracker

This is a Visual Basic .NET Windows Forms application that serves as a combined workout and nutrition tracker. The application allows users to:

- **Track Workouts:**
  - Use pre-defined or custom workout templates.
  - Log exercises and sets.
  - Save completed workouts as new templates (persisted between sessions).

- **Track Nutrition:**
  - Search for foods via the FatSecret API.
  - Select serving sizes and quantities to calculate nutritional macros.
  - Log daily food consumption with summarized macro totals.
  - Persist daily logs using JSON storage.

---

## Features

- **Workout Tracker:**
  - Pre-loaded with a default "Leg Day" template.
  - Create new workouts from templates or start a blank workout.
  - Add exercises and sets with live updates.
  - Option to save completed workouts as templates.
  - Templates are stored on disk (JSON file) and are available on subsequent launches.

- **Nutrition Tracker:**
  - Integrates with the FatSecret API to search and retrieve food details.
  - Select serving sizes and specify quantities.
  - Automatically calculates and displays nutritional information (calories, protein, carbs, and fat).
  - Daily logs are saved to a JSON file and can be navigated by date.

- **General Enhancements:**
  - Robust error handling and input validation.
  - Persistent storage for workout templates and daily nutrition logs.
  - Clean and responsive UI using Windows Forms.

---

## Technologies Used

- **Language & Framework:** Visual Basic .NET, Windows Forms  
- **APIs:** FatSecret API for nutrition data  
- **Persistence:** JSON file storage (using [Newtonsoft.Json](https://www.newtonsoft.com/json))  
- **Development Environment:** Visual Studio

---

## Installation & Setup

1. **Clone the Repository:**

   ```bash
   git clone https://github.com/yourusername/your-repo-name.git
   ```

2. **Open the Project:**  
   Open the solution (.sln) file in Visual Studio.

3. **Restore NuGet Packages:**  
   Ensure that all NuGet packages (e.g., Newtonsoft.Json) are restored.  
   In Visual Studio, go to **Tools > NuGet Package Manager > Package Manager Console** and run:

   ```bash
   Update-Package -reinstall
   ```

4. **Configure FatSecret API Keys (Optional):**  
   The FatSecret API helper file (`FatSecretApiHelper.vb`) contains default keys.  
   If you have your own credentials, update the `CLIENT_ID` and `CLIENT_SECRET` constants.

5. **Build & Run:**  
   Build the solution and run the project.  
   The main form will prompt you to choose between the Workout Tracker and Nutrition Tracker.

---

## Usage

### Workout Tracker

1. **Main Form:** Choose **Workout Tracker** to view available workout templates.
2. **Template Panel:** Click on a template (e.g., "Leg Day") to load it, or click **Start Empty Workout** to begin a new session.
3. **Workout Session:**
   - Add exercises and sets as needed.
   - Mark sets as complete.
   - Use the timer to track your workout duration.
   - When finished, choose to save your workout as a new template if desired. This new template is saved to a JSON file and will be available in future sessions.

### Nutrition Tracker

1. **Main Form:** Choose **Nutrition Tracker** from the main menu.
2. **Daily Log:** View and navigate daily logs with summarized macros.
3. **Food Search:**
   - Enter a search term and click **Search** to retrieve food results from the FatSecret API.
   - Select a food result, choose a serving size, and specify the quantity.
   - Add the food to the current day's log.
4. **Daily Summary:** The application displays consumed, burned, and remaining energy along with detailed macros for the day.

---

## File Structure

### Forms & Controls
- `MainForm.vb`: Application launcher.
- `NutritionForm.vb`: Daily nutrition log and food entry.
- `FoodSearchForm.vb`: Food search and selection interface.
- `WorkoutForm.vb`: Displays available workout templates.
- `WorkoutFormIndividual.vb`: Interface for individual workout sessions.
- `ExerciseControl.vb`: User control for logging individual exercises and sets.
- Associated Designer files for each form/control.

### Helpers & Data Classes
- `JSONStorageHelper.vb`: Handles saving/loading daily logs to JSON.
- `WorkoutDataStore.vb`: Manages workout templates, including persistence.
- `FatSecretApiHelper.vb`: Interfaces with the FatSecret API.
- `WorkoutDataClasses.vb`: Contains definitions for `Workout`, `WorkoutTemplate`, `Exercise`, and `ExerciseSet`.

---

## Contributing

Contributions are welcome! Please feel free to fork this repository and submit pull requests. If you find any issues or have suggestions for improvements, open an issue on GitHub.

---

## License

This project is licensed under the [MIT License](LICENSE).

---

## Acknowledgements

- **FatSecret API** for providing nutrition data.
- **Newtonsoft.Json** for JSON parsing and serialization.
- Inspiration from various fitness and nutrition tracking apps.