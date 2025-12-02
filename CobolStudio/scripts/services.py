import json
from os import error


def inspect(obj):
    """Inspect an object and return its attributes and methods."""
    gui_service("inspect", json.dumps(obj))


def compile_cobol(file_name):
    """Compile a cobol file and return its model."""
    return compiler_service("compile_cobol", json.dumps(file_name))
