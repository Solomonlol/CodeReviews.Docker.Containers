# MathGame

A console .NET application for practicing mental arithmetic. The user selects an arithmetic operation (addition, subtraction, multiplication, division), a difficulty level, and solves generated problems. Session results are stored and available through the history menu.

## Stack

- .NET 10 (Console App)
- Docker (multi-stage build)

## Running with Docker

### Option A: Run the pre-built image from Docker Hub

No need to clone the repository or build anything — just pull and run the image directly:

```bash
docker pull solomonlol/mathgame:v1.2
docker run -it --rm solomonlol/mathgame:v1.2
```

With arguments:

```bash
docker run -it --rm solomonlol/mathgame:v1.2 --difficulty Hard
```
### Option B: Build the image yourself

#### 1. Build the image

Clone the repository and build the image from the project root (where the `Dockerfile` is located):

```bash
git clone https://github.com/Solomonlol/CodeReviews.Docker.Containers.git
cd Solomonlol.MathGame
docker build -t mathgame .
```

#### 2. Run the container

The application is interactive (it waits for keyboard input), so you must use the `-it` flags:

```bash
docker run -it --rm mathgame
```

- `-i` — attaches stdin (so the app can receive input);
- `-t` — allocates a pseudo-terminal (for correct console rendering);
- `--rm` — automatically removes the container after it exits.

> ⚠️ If you run the container via the "Run" button in Docker Desktop without interactive mode, the app will crash when it tries to read from the console. Use `docker run -it` from a terminal instead.

## Command-line arguments

The application supports optional arguments that let you skip part of the manual input.

| Flag | Short form | Description | Allowed values |
|---|---|---|---|
| `--difficulty` | `-d` | Game difficulty level | `Easy`, `Medium`, `Hard` (case-insensitive) |

### Examples

Run with difficulty specified:

```bash
docker run -it --rm mathgame --difficulty Hard
```

Short form:

```bash
docker run -it --rm mathgame -d Easy
```

Run with no arguments (difficulty will be requested via the menu, as usual):

```bash
docker run -it --rm mathgame
```

If an invalid difficulty value is passed (e.g. `--difficulty Impossible`), the app will print a warning to the console and continue normally (difficulty will be requested via the menu).

## Running locally without Docker

```bash
dotnet run --project STUDY.MathGame.csproj -- --difficulty Medium
```

## Thoughts

It was fun, and it turned out not to be as difficult as I thought.

Of course, it’s just a simple project—no SQL, web connections, or anything like that. Still, though—it really wasn't hard at all.
