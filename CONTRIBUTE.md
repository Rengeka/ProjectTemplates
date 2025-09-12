# Contributing Guidelines

Thank you for wanting to contribute to this project templates repositoryю  
Below are the guidelines and recommendations for adding new templates.

## 📂 Repository Structure
Each template should be stored in its own folder following this structure:

    Templates/
    ├─ C#/
    │ └─ ASP.NET/
    │ ├─ SampleTemplate/
    │ │ ├─ README.md
    │ │ └─ ... (other project files)
    │ └─ SampleTemplate2/
    │ ├─ README.md
    │ └─ ... (other project files)
    ├─ Python/
    │ └─ SampleTemplate/
    │ ├─ README.md
    │ └─ ... (other project files)
    └─ ... (other languages)


You may create direcoties specific for a technology or framework

> Notes:
> - Use **PascalCase** for folder names (`SampleTemplate` instead of `sample-template`).  
> - Each template folder **must** include a `README.md` and any necessary project files.

## 🚀 How to Propose a Change
1. **Fork** this repository.  
2. Create a new branch for your change:  
   ```bash
   git checkout -b my-template
   ```
3. Add or modify your template(s) following the guidelines above.
4. Commit your changes with a clear message:
    ```bash
    git add .
    git commit -m "Add ASP.NET Core SampleTemplate"
    ```
5. Push your branch to your fork:
    ```bash
    git push origin my-template
    ```
6. Open a **Pull Request** to the main repository. Include in your PR description:
    What you added or changed

    Any special instructions for running the template

    Verification that it builds/runs correctly
    
    Add **Rengeka** to reviewers
7. Always squash commits before merging to main!

## ✅ Do
- Add a **project description**, **architecture overview**, and any **specific naming conventions** into `README.md`.  
- Ensure your template **builds and runs successfully**.  
- Include a proper `.gitignore` for your language/framework.  
- Keep dependencies **minimal** and only what’s necessary to start.


## ❌ Do Not
- Do not violate folder or file naming conventions.  
- Do not include IDE-specific or OS-specific files (`.vs/`, `.idea/`, `__pycache__/`, etc.).  
- Do not add unnecessary dependencies or large files.  
- Do not submit incomplete templates without a proper `README.md`.

---

Thank you for contributing! 🚀