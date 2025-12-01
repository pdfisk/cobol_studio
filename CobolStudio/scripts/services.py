import json
from os import error


def inspect(obj):
    """Inspect an object and return its attributes and methods."""
    gui_service("inspect", json.dumps(obj))


def compile_cobol(obj):
    """Compile a cobol file and return its model."""
    model = compiler_service("compile_cobol", json.dumps(obj))
    return json.loads(model.as_json())
