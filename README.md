# Ieltsy

IELTS Writing Practice Tool ✍️📊

A web application to help students prepare for the **IELTS Academic Writing Tasks**. Built with **.NET 9** (backend), **Angular** (frontend), and **Bootstrap** for styling.

## Features

-   📝 Practice multiple IELTS Writing tasks
-   ⏱️ timer.
-   🔢 word count
-   🤖 AI-powered grading (0–100%)
-   📉 AI feedback if grade less than 70%

## How It Works

1. Choose from a list of IELTS sample questions.
2. Submit your answer to get instant AI feedback and grading.

## Setup Instructions

### Frontend (Angular)

1. Install dependencies:

    ```bash
    npm install
    ```

2. Update environment settings:

    - Get a **Free Trual API Key** from CohereAI https://cohere.com/
    - Add your **Free Trual API Key** to the environment file (`src/environments/environment.ts`)
    - Set the **backend API URL** in the same environment file e.g (`https://localhost:7286`)

3. Run the frontend:

    ```bash
    ng serve
    ```

### Backend (.NET 9)

1. Set `Server.API` as the **startup project** in your solution.

2. Open `appsettings.json` and update the **connection string** to match your local database configuration.

3. Open the **Package Manager Console** (from `Tools > NuGet Package Manager > Package Manager Console`).

4. Run the following commands to create and apply the database migration with seed data:

    ```powershell
    Add-Migration InitialCreate
    Update-Database
    ```

5. Press **F5** or click **Start** to run the backend server.

## Tech Stack

-   **Frontend:** Angular, Bootstrap
-   **Backend:** .NET 9 Web API
-   **AI Integration:** CohereAI
-   **Styling:** Bootstrap
