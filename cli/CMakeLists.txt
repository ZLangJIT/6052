cmake_minimum_required(VERSION 3.18.8)

include(CheckSymbolExists)

add_executable(emu_main_cli)
target_sources(emu_main_cli PRIVATE main.cpp)
if (TERMUX_NIX)
  target_link_libraries(emu_main_cli PRIVATE emu_main EGL GLESv2)
elseif (TERMUX)
  target_link_libraries(emu_main_cli PRIVATE emu_main EGL GLESv3 log)
else()
  target_link_libraries(emu_main_cli PRIVATE emu_main EGL GLESv3)
endif()
install(TARGETS emu_main_cli DESTINATION bin)
