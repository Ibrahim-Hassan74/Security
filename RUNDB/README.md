# RUNDB - Password Database Setup Tool

This tool populates the `pwned_passwords` database table with SHA1 hashes from the RockYou password list.

## Quick Start

**No code changes needed!** Just place the file and run.

1. **Get rockyou.txt** (download separately, not in repo)
2. **Place it here**: `RUNDB\bin\Debug\net8.0\rockyou.txt` (same folder as the .exe when running from Visual Studio)
3. **Run**: Press F5 in Visual Studio with RUNDB as startup project
4. **Wait**: ~1-2 minutes to process 14M passwords

## For GitHub Users

1. Clone the repository
2. Download rockyou.txt (not included due to size)
3. Build and run the SecuritySolution app first (creates database)
4. Place rockyou.txt in `RUNDB\bin\Debug\net8.0\` folder
5. Right-click RUNDB project → "Set as Startup Project" → Press F5
6. Wait for completion (~1-2 min)
7. Return to SecuritySolution - password checking now works!

## Why This Location?

The code uses a **relative path**: `".\rockyou.txt"`

This means it looks in the same folder as the running executable:
- **Debug build**: `RUNDB\bin\Debug\net8.0\PreparePasswordsDB.exe` → place rockyou.txt there
- **Release build**: `RUNDB\bin\Release\net8.0\PreparePasswordsDB.exe` → place rockyou.txt there

**No source code changes required!**

## Configuration

**Database**: `Security.dbo.pwned_passwords`  
**RockYou Path**: `.\rockyou.txt` (relative to exe - automatically finds it)  
**Connection**: Local SQL Server with Windows Authentication
